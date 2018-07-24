import pygame

pygame.init()

resolution = (600, 600)
gameDisplay = pygame.display.set_mode(resolution)
pygame.display.set_caption('Wanderer the RPG Game')
clock = pygame.time.Clock()

gameExit = False

while not gameExit:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            gameExit = True

        print(event)

    pygame.display.update()
    clock.tick(60)


pygame.quit()
